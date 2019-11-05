using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.MiniProject208;
using ViewModel.MiniProject208;

namespace Repo.MiniProject208
{
    public class AccessMenuRepo
    {
        public static List<VMAccess> getAccess(long ids, long roles)
        {
            List<VMAccess> data = new List<VMAccess>();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from a in db.x_addrbook
                        join ur in db.x_userrole on a.id equals ur.addrbook_id
                        join r in db.x_role on ur.role_id equals r.id
                        join ma in db.x_menu_access on r.id equals ma.role_id
                        join m in db.x_menutree on ma.menutree_id equals m.id
                        where a.id == ids && r.id == roles
                        orderby m.menu_order

                        select new VMAccess
                        {
                            id = a.id,
                            email = a.email,
                            abuid = a.abuid,
                            menutree_id = m.id,
                            role_id = r.id,
                            title = m.title,
                            menu_image_url = m.menu_image_url,
                            menu_icon = m.menu_icon,
                            menu_order = m.menu_order,
                            menu_level = m.menu_level,
                            menu_parent = m.menu_parent,
                            menu_url = m.menu_url,
                            menu_type = m.menu_type,
                            name = r.name
                        }).ToList();

            }
            return data;
        }
        public static List<VMAccess> getRole(long id)
        {
            List<VMAccess> data = new List<VMAccess>();

            using (DBMiniProject208Entities db = new DBMiniProject208Entities())
            {
                data = (from a in db.x_addrbook
                        join ur in db.x_userrole on a.id equals ur.addrbook_id
                        join r in db.x_role on ur.role_id equals r.id
                        where a.id == id
                        orderby r.id

                        select new VMAccess
                        {
                            role_id = r.id,
                            name = r.name
                        }).ToList();
            }
            return data;
        }
    }
}
