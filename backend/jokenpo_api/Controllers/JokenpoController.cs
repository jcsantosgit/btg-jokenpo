using jokenpo_api.Models;
using Microsoft.AspNetCore.Mvc;

namespace jokenpo_api.Controllers;

[ApiController]
[Route("api/[controller]/")]
public class JokenpoController : ControllerBase
{
    private List<JokenpoModel> _list;

    public JokenpoController()
    {
        _list = new List<JokenpoModel>() 
        {
            new JokenpoModel(1, "Tesoura", "Papel, Lagarto"),
            new JokenpoModel(2, "Papel", "Pedra, Spock"),
            new JokenpoModel(3, "Pedra", "Tesoura, Lagarto"),
            new JokenpoModel(4, "Lagarto", "Spock, Papel"),
            new JokenpoModel(5, "Spock", "Tesoura, Pedra")
        };        
    }

    [HttpGet]
    public IActionResult get()
    {
        return Ok(_list);
    }

    [HttpGet("{id}")]
    public IActionResult getById(int id)
    {
        try
        {
            var result = _list.Where(l=>l.Id == id).FirstOrDefault();   
            return Ok(result);
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message); // poderia ser guardada em um log.
            return this.StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro durante sua requisição :("); // Mensagem amigavel para o usuário
        }
    }

    [HttpGet("play/{id}")]
    public IActionResult play(int id)
    {
        try
        {
            var playerBet = _list.Where(l=>l.Id == id).FirstOrDefault();    
            if(playerBet == null) return NotFound("Item não encontrado");

            Random rnd = new Random();

            int rndNumber = rnd.Next(1,5);

            var drawn = _list.Where(l=>l.Id == rndNumber).FirstOrDefault();

            var result = new JokenpoResult();

            result.Player = playerBet;
            result.Game = drawn;

            if(playerBet.Name.Equals(drawn.Name))
                result.Message = "Você empatou!";
            else if(playerBet.WinsFrom.Contains(drawn.Name))
                result.Message = "Parabéns! Você ganhou!";
            else
                result.Message = "Sinto muito! Você perdeu.";

            return Ok(result);
            
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message); // poderia ser guardada em um log.
            return this.StatusCode(StatusCodes.Status500InternalServerError, "Ocorreu um erro durante sua requisição :("); // Mensagem amigavel para o usuário
        }
    }
}