using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic : Producto
    {
        public enum TipoComic { Occidental, Oriental };
        private TipoComic tipoComic;
        private string autor;

        #region metodos

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipocomic) :
            base(descripcion, stock, precio)
        {
            this.tipoComic = tipocomic;
            this.autor = autor;
        }

        #endregion


    }
}
