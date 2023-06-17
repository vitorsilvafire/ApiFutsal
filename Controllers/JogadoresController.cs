using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ApiFutsal.Models;
using ApiFutsal.Models.Enuns;
using ApiFutsal.Data;
namespace ApiFutsal.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class    JogadoresController : ControllerBase
    {
        private readonly DataContext _context;
        
        public JogadoresController(DataContext context)
        {
            _context = context;
        }
    [HttpGet("GetAll")]
     public async Task<IActionResult> Get()
     {
        try
        {
           List<Jogadores> lista = await _context.Jogadores.ToListAsync();
           return Ok(lista);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
     }
    [HttpPost]
public async Task<IActionResult> Add(Jogadores novoJogador)
{
    try
    {
        if (novoJogador.Posicao != PosicaoEnum.Pivo && novoJogador.Posicao != PosicaoEnum.Ala && novoJogador.Posicao != PosicaoEnum.Goleiro && novoJogador.Posicao != PosicaoEnum.Fixo)
        {
            throw new Exception("Posicao inexistente");
        }
        
        await _context.Jogadores.AddAsync(novoJogador);
        await _context.SaveChangesAsync();

        return Ok("Jogador adicionado com sucesso");
    }
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
}




     [HttpPut]
public async Task<IActionResult> Update(Jogadores novoJogador)
{
    try
    {
        int posicaoInt = (int)novoJogador.Posicao;
        if (posicaoInt != 1 && posicaoInt != 2 && posicaoInt != 3 && posicaoInt != 4)
        {
            throw new Exception("Posição inexistente");
        }
        
        _context.Jogadores.Update(novoJogador);
        await _context.SaveChangesAsync();

        return Ok("Jogador atualizado com sucesso");
    }
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
}
/*[HttpDelete("{id}")]
public async Task<IActionResult> Delete(int id)
{
    try
    {
        Jogadores jogador = await _context.Jogadores.FindAsync(id);

        if (jogador == null)
        {
            return NotFound("Jogador não encontrado");
        }

        _context.Jogadores.Remove(jogador);
        await _context.SaveChangesAsync();

        return Ok("Jogador deletado");
    }
    catch (Exception ex)
    {
        return BadRequest(ex.Message);
    }
}*/

[HttpDelete("{id}")]
     public async Task<IActionResult> Delete(int id)
     {
        try
        {
            Jogadores pRemover = await _context.Jogadores.FirstOrDefaultAsync(p => p.Id == id);

            _context.Jogadores.Remove(pRemover);
            int linhaAfetadas = await _context.SaveChangesAsync();
            return Ok(linhaAfetadas);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
     }



    

}
}