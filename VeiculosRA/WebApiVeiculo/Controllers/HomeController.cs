using Data.Models;
using Data.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiVeiculo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController<T, R> : ControllerBase where T : BaseModel where R : BaseRepository<T>
    {
        R repo = Activator.CreateInstance<R>();
        
        [HttpPost]
        public void Post([FromBody] T model)
        {
            repo.Create(model);
        }
        [HttpGet]
        public List<T> Get()
        {
            return repo.Read();
        }
        [HttpGet("{Id}")]
        public T Get(int id)
        {
            return repo.Read(id);
        }
        [HttpPut("{Id}")]
        public void Put(int id, [FromBody] T model)
        {
            model.Id = id;
            repo.Update(model);
        }
        [HttpDelete("{Id}")]
        public void Delete(int id)
        {
            repo.Delete(id);
        }

    }
}
