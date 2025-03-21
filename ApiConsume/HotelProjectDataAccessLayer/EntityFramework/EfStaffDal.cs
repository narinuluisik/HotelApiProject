using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProjectDataAccessLayer.Abstract;
using HotelProjectDataAccessLayer.Concrete;
using HotelProjectDataAccessLayer.Repositories;
using HotelProjectEntityLayer.Concrete;
namespace HotelProjectDataAccessLayer.EntityFramework
{
    public class EfStaffDal : GenericRepository<Service>, IServicesDal
    {

        public EfStaffDal(Context context) : base(context)
        {

        }
    }
}
