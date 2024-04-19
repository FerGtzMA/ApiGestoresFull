using apiGestores.Context;
using apiGestores.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace apiGestores.Controllers
{
    [Route("api/[controller]")]
    public class GestoresController : Controller
    {
        private readonly AppDbContext _context;
        public GestoresController(AppDbContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.gestoresBD.ToList());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("{id}", Name = "GetGestor")]
        public ActionResult Get(int id)
        {
            try
            {
                var gestor = _context.gestoresBD.FirstOrDefault(g => g.id == id);
                return Ok(gestor);
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public ActionResult Post([FromBody] gestoresBD gestor) 
        {
            try
            {
                _context.gestoresBD.Add(gestor); 
                _context.SaveChanges();
                return CreatedAtRoute("GetGestor", new { id = gestor.id }, gestor); // devolvemos al usuario el usuario que se inserto con su id
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody]gestoresBD gestor)
        {
            try
            {
                _context.Entry(gestor).State = EntityState.Modified; 
                _context.SaveChanges();
                return CreatedAtRoute("GetGestor", new { id = gestor.id }, gestor);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var gestor = _context.gestoresBD.FirstOrDefault(g => g.id == id);
                if (gestor != null)
                {
                    _context.gestoresBD.Remove(gestor);
                    _context.SaveChanges();
                    return Ok(gestor);
                }
                else
                {
                    return BadRequest();
                }
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
