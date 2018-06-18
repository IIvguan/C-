using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 访问者模式
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee zhangsan = new Teacher("张三", 2500.0, 14);            Employee lisi = new Engineer("李四", 3500.0, 16);            Employees e = new Employees();            e.Attach(zhangsan);            e.Attach(lisi);

            IncomeVisitor v1 = new IncomeVisitor();            VacationVisitor v2 = new VacationVisitor();

            e.Accept(v1);            e.Accept(v2);            Console.Read();
        }
    }
    /// <summary>
    /// 抽象员工
    /// </summary>
    abstract class Employee    {
        public string Name { get; set; }        public double Income { get; set; }        public int VacationDays { get; set; }        abstract public void Accept(Visitor visitor);    }
    class Teacher : Employee    {        public Teacher(string name, double income, int vacationDays)        {            Name = name;            Income = income;            VacationDays = vacationDays;        }        public override void Accept(Visitor visitor)        {            visitor.Visit(this);        }    }
    class Engineer : Employee    {        public Engineer(string name, double income, int vacationDays)        {            Name = name;            Income = income;            VacationDays = vacationDays;        }        public override void Accept(Visitor visitor)        {            visitor.Visit(this);        }    }    /// <summary>
    /// 访问者
    /// </summary>    abstract class Visitor    {        abstract public void Visit(Employee element);    }    class IncomeVisitor : Visitor    {        public override void Visit(Employee element)        {            element.Income *= 1.10;            Console.WriteLine(element.Name + "的新工资是: " + element.Income);        }    }    class VacationVisitor : Visitor    {        public override void Visit(Employee element)        {            element.VacationDays += 3;            Console.WriteLine(element.Name + "的新假期是" + element.VacationDays);        }    }    /// <summary>
    /// 成员集合
    /// </summary>    class Employees    {        private ArrayList employees = new ArrayList();        public void Attach(Employee employee)        {            employees.Add(employee);        }        public void Detach(Employee employee)        {            employees.Remove(employee);        }        public void Accept(Visitor visitor)        {            foreach (Employee e in employees)                e.Accept(visitor);        }    }
}
