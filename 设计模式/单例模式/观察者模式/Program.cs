using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 观察者模式
{
    
        interface Message_Kinds
        {
            void Attach(Customer customer);
            void Detach(Customer customer);
            void Notify();
            string Message_kindsState
            {
                get;
                set;
            }
        }

        abstract class Customer
        {
            protected string name;
            protected Message_Kinds Kinds;

            public Customer(string name, Message_Kinds Kinds)
            {
                this.name = name;
                this.Kinds = Kinds;
            }

            public abstract void Update();
        }


        #region 普通会员
        //普通会员
        class Membercustomer : Customer
        {
            public Membercustomer(string name, Message_Kinds Kinds)
                : base(name, Kinds)
            {
            }
            public override void Update()
            {
                Console.WriteLine("{0};普通会员{1}收到通知！", Kinds.Message_kindsState, name);
            }
        }
        #endregion

        #region  VIP会员
        class VIPcustomer : Customer
        {
            public VIPcustomer(string name, Message_Kinds Kinds) : base(name, Kinds)
            {
            }
            public override void Update()
            {
                Console.WriteLine("{0};VIP会员{1}收到通知！", Kinds.Message_kindsState, name);
            }
        }
        #endregion

        class Productname : Message_Kinds
        {
            #region 会员列表
            private IList<Customer> customers = new List<Customer>();
            #endregion
            private string action;
            public string name;
            #region 增加连接
            public void Attach(Customer customer)
            {
                customers.Add(customer);
            }
            #endregion
            #region 减少
            public void Detach(Customer customer)
            {
                customers.Remove(customer);
            }
            #endregion
            #region  通知消息
            public void Notify()
            {
                foreach (Customer o in customers)
                    o.Update();
            }
            //名字信息
            #endregion
            public string Message_kindsState
            {
                get { return action; }
                set { action = value; }
            }
            //设置商品名
            public void setname(string name)
            {
                this.name = name;
            }

        }


        class Productprice : Message_Kinds
        {
            //会员列表
            private IList<Customer> customers = new List<Customer>();
            private string action;
            public double price;
            //增加连接
            public void Attach(Customer customer)
            {
                customers.Add(customer);
            }
            //减少连接
            public void Detach(Customer customer)
            {
                customers.Remove(customer);
            }
            //通知消息
            public void Notify()
            {
                foreach (Customer o in customers)
                    o.Update();
            }
            //价格信息
            public string Message_kindsState
            {
                get { return action; }
                set { action = value; }
            }
            //设置价格
            public void setprice(double price)
            {
                this.price = price;
            }

        }
    class Program
    {
        static void Main(string[] args)
        {

            Productname name = new Productname();
            name.setname("皮肤");
            Productprice price = new Productprice();
            price.setprice(50);

            //普通会员
            Membercustomer member1 = new Membercustomer("小明", name);
            //VIP会员
            VIPcustomer VIP1 = new VIPcustomer("阿伟", name);
            //普通会员
            Membercustomer member2 = new Membercustomer("大基佬", price);
            //VIP会员
            VIPcustomer VIP2 = new VIPcustomer("小狼", price);

            name.Attach(member1);
            name.Attach(VIP1);

            price.Attach(member2);
            price.Attach(VIP2);

            //商品名更改
            name.Message_kindsState = "商品名已经更改为:" + name.name;
            //发出通知
            name.Notify();

            //价格更改
            price.Message_kindsState = "商品价格已经更改为:" + price.price;
            //发出通知
            price.Notify();

            Console.Read();
        }
    }
}
