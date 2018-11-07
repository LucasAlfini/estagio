using LFSoft.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LFSoft.Controller
{
    public class CargoController
    {
        public void getCargo(int id)
        {
            var contexto = new Contexto();
            Cargo cargo = contexto.Cargo.Where(c => c.ID_Cargo == id) as Cargo;
            var cargos = contexto.Cargo; //select * from cargo
            foreach(Funcionario f in cargo.Funcionario)
            {

            }
            Cargo f = new Cargo()
            {
                ID_Cargo = 1,
                Cargo1 = "fudfuadi",
            };
            contexto.Cargo.Add(f);
            contexto.SaveChanges();

        }
    }
}
