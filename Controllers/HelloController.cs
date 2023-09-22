using Microsoft.AspNetCore.Mvc;

namespace helloworld.Controllers
{

    [Route("~/")]
    [ApiController]
    public class HelloController
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello World!";
        }

        [HttpGet("/bsmsgeneration")]
        public string BsmGeneration()
        {
            return "BSM’s da Generation Brasil:\nPersistência\nMentalidade de Crescimento\nResponsabilidade pessoal\nOrientação ao Futuro\nComunicação\nProatividade\nOrientação ao Detalhe\nTrabalho em Equipe";
        }

        [HttpGet("/aprendizagem")]
        public string AprendizagemSemana()
        {
            return "O objetivo de aprender as funcionalidades do aspnet\nAplicar as funcionalidadesg\nAprender sobre a edição do meu GitHub e Linkedin ";
        }
    }
}
