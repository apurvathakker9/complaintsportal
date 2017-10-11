using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccess
{
    public class DepartmentDA
    {
        public static bool Add(Department info)
        {
            if (info.VillageId != 0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into Departments(DepartmentTypeId, Name, StateId, CityId, VillageId, LocalityId, OfficeAddress, Website, ContactEmails, ContactNumbers, ContactTimings) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')", info.DepartmentTypeId, info.Name, info.StateId, info.CityId, info.VillageId, info.LocalityId, info.OfficeAddress, info.Website, info.ContactEmails, info.ContactNumbers, info.ContactTimings));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("insert into Departments(DepartmentTypeId, Name, StateId, CityId, LocalityId, OfficeAddress, Website, ContactEmails, ContactNumbers, ContactTimings) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", info.DepartmentTypeId, info.Name, info.StateId, info.CityId, info.LocalityId, info.OfficeAddress, info.Website, info.ContactEmails, info.ContactNumbers, info.ContactTimings));
            }
        }

        public static bool Update(Department info)
        {
            if (info.VillageId != 0)
            {
                return BaseDataAccess.ExecuteSQL(String.Format("update Departments set DepartmentTypeId='{0}', Name='{1}', StateId='{2}',CityId='{3}',VillageId='{4}',LocalityId='{5}',OfficeAddress='{6}',Website='{7}',ContactEmails='{8}',ContactNumbers='{9}', ContactTimings='{10}' where Id='{11}'", info.DepartmentTypeId, info.Name, info.StateId, info.CityId, info.VillageId, info.LocalityId, info.OfficeAddress, info.Website, info.ContactEmails, info.ContactNumbers, info.ContactTimings, info.Id));
            }
            else
            {
                return BaseDataAccess.ExecuteSQL(String.Format("update Departments set DepartmentTypeId='{0}', Name='{1}', StateId='{2}',CityId='{3}',LocalityId='{4}',OfficeAddress='{5}',Website='{6}',ContactEmails='{7}',ContactNumbers='{8}', ContactTimings='{9}' where Id='{10}'", info.DepartmentTypeId, info.Name, info.StateId, info.CityId, info.LocalityId, info.OfficeAddress, info.Website, info.ContactEmails, info.ContactNumbers, info.ContactTimings, info.Id));
            }
        }

        public static bool Delete(Department info)
        {
            return BaseDataAccess.ExecuteSQL(String.Format("delete from Departments where Id='{0}'", info.Id));
        }

        public static Department GetDetails(int id)
        {
            Department info = null;
            info = BaseDataAccess.GetRecords<Department>(String.Format("select * from Departments where Id='{0}'  ", id));
            if (info != null)
            {
                return info;
            }
            else
            {
                return null;
            }
        }

        public static Department GetDetailsByLocationAndType(int stateId, int cityId, int villageId, int localityId, int departmentTypeId)
        {
            String sql = null;
            if (villageId != 0)
            {
                sql = String.Format("select * from Departments where StateId='{0}' and CityId='{1}' and VillageId='{2}' and LocalityId='{3}' and DepartmentTypeId='{4}' ", stateId, cityId, villageId, localityId, departmentTypeId);
            }
            else
            {
                sql = String.Format("select * from Departments where StateId='{0}' and CityId='{1}' and LocalityId='{2}' and DepartmentTypeId='{3}' ", stateId, cityId, localityId, departmentTypeId);
            }
            Department info = null;
            info = BaseDataAccess.GetRecords<Department>(sql);
            if (info != null)
            {
                return info;
            }
            else
            {
                return null;
            }
        }

        public static List<Department> GetAll()
        {
            List<Department> list = null;
            list = BaseDataAccess.GetRecordsList<Department>(String.Format("select * from Departments "));

            foreach (Department info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                info.Village = VillageDA.GetDetails(info.VillageId);
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
            }
            return list;
        }

        /// <summary>
        /// THis function is to be edited. Once the Logic is done.
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public static List<Department> GetAllByUseraname(string username)
        {
            List<Department> listDepartment = new List<Department>();

            GovernmentOfficial info = null;
            info = GovernmentOfficialDA.GetDetailsByContactNumber(username);

            List<DepartmentXOfficial> listoff = new List<DepartmentXOfficial>();
            if (info != null)
            {
                listoff = DepartmentXOfficialsDA.GetAllForOfficial(info.Id);
            }

            foreach (DepartmentXOfficial i in listoff)
            {
                Department dept = null;
                dept = GetDetails(i.DepartmentId);

                listDepartment.Add(dept);
            }
            return listDepartment;
        }
        /// <summary>
        /// This function returns list of Departments for a specific state, city or village and its locality.
        /// </summary>
        /// <param name="stateId"></param>
        /// <param name="cityId"></param>
        /// <param name="villageId"></param>
        /// <param name="localityId"></param>
        /// <param name="departmentTypeId"></param>
        /// <returns></returns>
        public static List<Department> GetAllByLocationAndType(int stateId, int cityId, int villageId, int localityId, int departmentTypeId)
        {
            String SQL = null;
            List<Department> list = null;
            if (villageId != 0)
            {
                SQL = String.Format("select * from Departments where StateId='{0}' and CityId='{1}' and VillageId='{2}' and LocalityId='{3}' and DepartmentTypeId='{4}' ", stateId, cityId, villageId, localityId, departmentTypeId);
            }
            else
            {
                SQL = String.Format("select * from Departments where StateId='{0}' and CityId='{1}' and LocalityId='{2}' and DepartmentTypeId='{3}' ", stateId, cityId, localityId, departmentTypeId);
            }
            list = BaseDataAccess.GetRecordsList<Department>(SQL);

            foreach (Department info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
            }
            return list;
        }

        public static List<Department> GetAllByType(int departmentTypeId)
        {
            return null;
        }

        public static List<Department> GetAllByState(int stateId)
        {
            return null;
        }

        public static List<Department> GetAllByCity(int cityId)
        {
            String SQL = null;
            List<Department> list = null;
            SQL = String.Format("select * from Departments where CityId='{0}' ", cityId);

            list = BaseDataAccess.GetRecordsList<Department>(SQL);

            foreach (Department info in list)
            {
                info.State = StateDA.GetDetails(info.StateId);
                info.City = CityDA.GetDetails(info.CityId);
                if (info.VillageId != 0)
                {
                    info.Village = VillageDA.GetDetails(info.VillageId);
                }
                info.Locality = LocalityDA.GetDetails(info.LocalityId);
                info.DepartmentType = DepartmentTypeDA.GetDetails(info.DepartmentTypeId);
            }
            return list;
        }

        public static List<Department> GetAllByVillageId(int villageId)
        {
            return null;
        }

        public static List<Department> GetAllByLocality(int localityId)
        {
            return null;
        }
    }
}
