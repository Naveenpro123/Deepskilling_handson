using Confluent.Kafka;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;


namespace Producer.Controllers
  
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProducerController : Controller
    {
        private readonly ProducerConfig _producerConfig;
        public ProducerController(ProducerConfig producerConfig)
        {
            _producerConfig = producerConfig;
        }
        [HttpPost("send")]

        public async Task<ActionResult> Get(string topic, [FromBody] Employee employee)
        {
            string seremployee = JsonConvert.SerializeObject(employee);
            using (var prod = new ProducerBuilder<Null, string>(_producerConfig).Build())
            {
                await prod.ProduceAsync(topic, new Message<Null, string> { Value = seremployee });
                prod.Flush(TimeSpan.FromSeconds(10));
                return Ok(true);
            }

        }
    }
    public class Employee
    {

        public int Id { get; set; }

        public string Name { get; set; }

       

    }
}
