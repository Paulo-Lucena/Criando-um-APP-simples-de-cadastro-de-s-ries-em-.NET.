using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Interfaces
{
    public interface iRepositorio<T>
    {
        List<T> Lista();

        T RetornaPorId(int id);

        void Insere(T entidade);

        void Excluir(int id);

        void Atualiza(int id, T entidade);

        int ProximoId();
    }
    
}