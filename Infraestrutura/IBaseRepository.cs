using CrudEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public interface IBaseRepository<T>
    {
        void Adicionar(T entity);
        List<T> Listar();
        void Editar(T entity);
        void Remover(int id);
        T BuscarPorId(int id);
    }

}
