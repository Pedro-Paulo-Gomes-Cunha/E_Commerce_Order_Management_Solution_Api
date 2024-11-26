using Domain.DTOs;
using Domain.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using Newtonsoft.Json;
using System.Text;
using RabbitMQ.Client.Events;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace E_Comerce_Web_Api.Controllers
{

	[Route("/api/v1/orders")]
	[ApiController]
	//[Authorize]
	public class OrderController:Controller
	{
		IOrderService _service;
		private readonly IConnection _connection;
		private readonly IModel _channel;

		public OrderController(IOrderService service)
		{
			_service = service;
			var factory = new ConnectionFactory() { HostName = "5.189.132.68", UserName = "dev", Password = "d3v12345"
			}; 
			_connection = factory.CreateConnection();
			_channel = _connection.CreateModel();
			_channel.QueueDeclare(queue: "orders", durable: false, exclusive: false, autoDelete: false, arguments: null);
		}

		[HttpGet()]
		public async Task<IActionResult> GetAll()
		{
			try
			{
				var consumer = new EventingBasicConsumer(_channel);
				consumer.Received += (model, event_) =>
				{
					var body = event_.Body.ToArray();
					var message = Encoding.UTF8.GetString(body);
					//Update
					var modell = (OrderDto)JsonConvert.DeserializeObject(message);
					if(modell != null)
					{
						modell.status = "Concluido";
						_service.Update(modell);
					}
				};
				_channel.BasicConsume(queue: "orders", autoAck: true, consumer: consumer);

				if (!ModelState.IsValid)
					return BadRequest();
				var orders = _service.FindAll();
				return Ok(orders);
			}
			catch (Exception e)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
			}
		}

		[HttpPost()]
		public async Task<IActionResult> Post(OrderDto data)
		{
			try
			{
				//using RabbitMQ
				_service.Save(data);
				var jsonMessage = JsonConvert.SerializeObject(data);
				var body = Encoding.UTF8.GetBytes(jsonMessage);
				_channel.BasicPublish(exchange: "", routingKey: "orders", basicProperties: null, body: body);

				return Ok(data);
			}
			catch (Exception e)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

			}
		}

		[HttpPut()]
		public IActionResult Put(OrderDto data)
		{
			try
			{
				//_service.Update(data);

				var jsonMessage = JsonConvert.SerializeObject(data);
				var body = Encoding.UTF8.GetBytes(jsonMessage);
				_channel.BasicPublish(exchange: "", routingKey: "orders", basicProperties: null, body: body);

				return Ok(data);
			}
			catch (Exception e)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

			}

		}
		[HttpDelete("{id}")]
		public IActionResult Delete(Guid id)
		{
			try
			{
				//_service.Remove(id);

				return Ok("Not implemented");
			}
			catch (Exception e)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, e.Message);

			}

		}

		[HttpGet("{id}")]
		public IActionResult GetById(Guid id)
		{
			try
			{
				if (!ModelState.IsValid)
					return BadRequest();

				var result = _service.FindById(id);

				if (result == null) return NotFound();

				return Ok(result);
			}
			catch (Exception e)
			{
				return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
			}
		}
	}
}
