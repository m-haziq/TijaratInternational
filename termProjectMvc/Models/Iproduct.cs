using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace termProjectMvc.Models
{
    public interface Iproduct
    {
        void save(product p, String c, String b, String f);
        void delete(int id);
        List<product> show();
        product edit(int id);
        void update(product p, string c, string b);
        List<product> getList(int range);
    }
}
