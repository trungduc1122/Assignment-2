using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObject;

namespace DataAccess
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = null;
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                }
                return instance;
            }
        }

        public Order GetOrderById(int id)
        {
            Order order = null;
            using var db = new FStoreDBAssignmentContext();
            order = db.Order.SingleOrDefault(x => x.OrderId == id);
            return order;
        }
        public void add(Order order)
        {
            Order order1 = GetOrderById(order.OrderId);
            if(order1== null)
            {
                using var db = new FStoreDBAssignmentContext();
                db.Order.Add(order);
                db.SaveChanges();
            }
        }
        public void update(Order order)
        {
            Order order1 = GetOrderById(order.OrderId);
            if (order1 != null)
            {
                using var db = new FStoreDBAssignmentContext();
                db.Order.Update(order);
                db.SaveChanges();
            }
        }
        public void delete(Order order)
        {
            Order order1 = GetOrderById(order.OrderId);
            if (order1 != null)
            {
                using var db = new FStoreDBAssignmentContext();
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }
    }
}
