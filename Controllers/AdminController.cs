//using Microsoft.AspNetCore.Mvc;
//using ASM.Models;


//public class AdminController : Controller
//{
//    public IActionResult Admin()
//    {
//        var orders = new List<Order>
//            {
//                new Order { OrderId = 1, CustomerName = "John Doe", PhoneNumber = "0123456789", TotalAmount = 100.00M, Status = "Đang xử lý" },
//                new Order { OrderId = 2, CustomerName = "Jane Smith", PhoneNumber = "0987654321", TotalAmount = 150.00M, Status = "Hoàn thành" }
//            };

//        var model = new AdminViewModel { Orders = orders };

//        // Trả về view và truyền model vào view
//        return View(model);
//    }

//    // Các hàm khác (thêm sản phẩm, quản lý đơn hàng, ...)
//}