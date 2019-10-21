using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Repository
    {
        public ContactesEntities dades; 

        public Repository() {

            dades = new ContactesEntities(); 
            
        
        }


        public List<contacte> Contactes() {

            List<contacte> llista = new List<contacte>();

            foreach (contacte cont in dades.contactes)
            {
                llista.Add(cont); 
            }


            return llista; 
        }





    }


}
