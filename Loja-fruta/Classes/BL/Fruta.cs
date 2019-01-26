using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Classes.VO;
using System.IO;

namespace Classes.BL
{
  public  class Fruta
    {
        public Fruta(string bt) { }
        public static void Cadastrar(VO.Fruta fruta,string path)
        {
            FileStream fileStream = new FileStream(path,FileMode.OpenOrCreate,FileAccess.Write);
            
            byte[] dado = Encoding.UTF8.GetBytes (Guid.NewGuid()+";"+fruta.Nome+"\r\n");
            fileStream.Write( dado, 0, dado.Length);
            fileStream.Close();
        }

       
    }
}
