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
    public class VeiculosController : HomeController<Veiculos, VeiculoRepository>
    {
    }
}
