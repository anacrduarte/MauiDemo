using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiControls.Models
{
    public class FotoViewModel
    {
        public ObservableCollection<Foto> fotos { get; private set; }

        public ObservableCollection<Foto> Fotos
        {
            get { return fotos; }
            set { fotos = value; }
        }

        public FotoViewModel()
        {
            Fotos = new ObservableCollection<Foto>()
            {
                new Foto(){ Name = "Andrômeda", ImageUrl = "gal1.jpg" },
                 new Foto(){ Name = "Via Láctea", ImageUrl = "gal2.jpg" },
                  new Foto(){ Name = "Universo", ImageUrl = "gal3.jpg" },
                   new Foto(){ Name = "Galáxia", ImageUrl = "gal4.jpg" },
                    new Foto(){ Name = "Espaço", ImageUrl = "gal5.jpg" },
                     new Foto(){ Name = "Andrômeda", ImageUrl = "gal1.jpg" },
                 new Foto(){ Name = "Via Láctea", ImageUrl = "gal2.jpg" },
                  new Foto(){ Name = "Universo", ImageUrl = "gal3.jpg" },
                   new Foto(){ Name = "Galáxia", ImageUrl = "gal4.jpg" },
                    new Foto(){ Name = "Espaço", ImageUrl = "gal5.jpg" },
            };
        }
    }
}
