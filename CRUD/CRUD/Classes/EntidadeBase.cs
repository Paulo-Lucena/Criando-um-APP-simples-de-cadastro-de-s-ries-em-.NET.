using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Classes
{
    public abstract class EntidadeBase
    {
        public int Id { get; protected set; }
    }
}