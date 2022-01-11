using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Information
{
    class InformationManager
    {
        public List<DepartmentInfo> GettAllDepartment()
        {
            var context = new PathfinderEntities();
            var q = from dep in context.DepartmentInfoes select dep;
            return q.ToList();
        }

        public List<GendarInfo> GettAllGender()
        {
            var context = new PathfinderEntities();
            var q = from gen in context.GendarInfoes select gen;
            return q.ToList();
        }

        public List<SemesterInfo> GettAllSemester()
        {
            var context = new PathfinderEntities();
            var q = from sem in context.SemesterInfoes select sem;
            return q.ToList();
        }

        public List<Religion> GettAllReligion()
        {
            var context = new PathfinderEntities();
            var q = from rel in context.Religions select rel;
            return q.ToList();
        }

        public List<ShiftInfo> GettAllShift()
        {
            var context = new PathfinderEntities();
            var q = from shi in context.ShiftInfoes select shi;
            return q.ToList();
        }

        public List<SP_GRIDVIEW_Result> GettAllInformation()
        {
            var context = new PathfinderEntities();
            var q = context.SP_GRIDVIEW();
            return q.ToList();
        }

        public List<SP_DepartmentWiseInformation_Result> GettAllDepartmentWiseInformation(int sId,int dId)
        {
            var context = new PathfinderEntities();
            var q = context.SP_DepartmentWiseInformation(sId,dId);
            return q.ToList();
        }

        public List<SP_LOGINUSERNAME_Result> GettAllNewuser()
        {
            var context = new PathfinderEntities();
            var q = context.SP_LOGINUSERNAME();
            return q.ToList();
        }

        public List<SP_DEPARTMENTINFONAME_Result> GettAllDepartmentName()
        {
            var context = new PathfinderEntities();
            var q = context.SP_DEPARTMENTINFONAME();
            return q.ToList();
        }
    }
}
