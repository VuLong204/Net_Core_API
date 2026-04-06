# NetCoreAPI

## 1. Cấu trúc thư mục dự án .NET MVC
Cấu trúc chuẩn của một dự án ASP.NET Core MVC bao gồm các thành phần chính:
- **Controllers**: Chứa các lớp điều khiển (Controller). Đây là nơi xử lý các yêu cầu (request) từ người dùng, thực thi logic nghiệp vụ và quyết định trả về View nào.
- **Models**: Chứa các lớp (Class) đại diện cho dữ liệu và các quy tắc nghiệp vụ (Business Logic).
- **Views**: Chứa các file giao diện (`.cshtml`), chịu trách nhiệm hiển thị thông tin cho người dùng (HTML/CSS).
- **wwwroot**: Thư mục gốc chứa các file tĩnh (Static files) công khai như: CSS, JavaScript, hình ảnh, icon.
- **appsettings.json**: File chứa các cấu hình của ứng dụng như: chuỗi kết nối cơ sở dữ liệu (Connection Strings), cấu hình log, v.v.
- **Program.cs**: Điểm nhập (Entry point) của ứng dụng. Nơi cấu hình các dịch vụ (Services), Middleware và định tuyến (Routing).

## 2. Định tuyến (Routing) trong .NET MVC
- **Khái niệm**: Routing là cơ chế ánh xạ (map) một đường dẫn URL (ví dụ: `/Student/Index`) tới một Action cụ thể bên trong một Controller để xử lý.
- **Cơ chế mặc định**: ASP.NET Core MVC sử dụng mẫu định tuyến mặc định: `{controller=Home}/{action=Index}/{id?}`.
  - Nếu người dùng không gõ gì, hệ thống tự động gọi `HomeController` và action `Index`.
  - Tham số `id` là tùy chọn (có thể có hoặc không).

## 3. Namespace trong C#
- **Khái niệm**: Namespace (Không gian tên) là từ khóa dùng để tổ chức và phân nhóm các lớp (Class), struct, interface,... có liên quan lại với nhau.
- **Mục đích**: Giúp code gọn gàng, dễ quản lý và tránh xung đột tên (Naming Conflict) khi sử dụng nhiều thư viện khác nhau có cùng tên lớp.

## 4. Controller và View
- **Controller**:
  - Đóng vai trò điều phối (Coordinator).
  - Nhận yêu cầu -> Xử lý Model -> Trả về View.
  - Một Controller thường chứa nhiều Action (ví dụ: `Index`, `Create`, `Edit`).
- **View**:
  - Đóng vai trò hiển thị (Presentation).
  - Không chứa logic nghiệp vụ phức tạp, chỉ chứa logic hiển thị.
  - Sử dụng Razor Engine (đuôi file `.cshtml`) để nhúng mã C# vào trong HTML.

## 5. ViewBag
- **Khái niệm**: `ViewBag` là một đối tượng động (dynamic object) dùng để truyền dữ liệu tạm thời từ Controller sang View.
- **Đặc điểm**: Dữ liệu chỉ tồn tại trong vòng đời của một Request. Cú pháp gán: `ViewBag.TenBien = "Gia tri";`.

## 6. Models
- **Khái niệm**: Model là thành phần đại diện cho cấu trúc dữ liệu của ứng dụng.
- **Vai trò**: Định nghĩa hình dạng của dữ liệu (ví dụ: Class `Student` gồm `StudentCode`, `FullName`) và truyền tải dữ liệu giữa Controller và View.

## 7. Gửi nhận dữ liệu (Submit Form)
Quá trình gửi dữ liệu từ View lên Controller thường thông qua `Form` với phương thức `POST`:
1. **Tại View**: Người dùng nhập liệu vào các thẻ `<input>` (có thuộc tính `name` khớp với tên biến trong Model) và bấm nút Submit.
2. **Cơ chế Model Binding**: Hệ thống tự động ánh xạ dữ liệu từ Form vào tham số của Action trong Controller.
3. **Tại Controller**: Action (có attribute `[HttpPost]`) nhận đối tượng và xử lý logic.

## 8. Layout (Giao diện dùng chung)
- **Khái niệm**: Layout là file mẫu giao diện chung cho các trang (thường là `_Layout.cshtml`).
- **Tác dụng**: Giúp định nghĩa các phần cố định như Header (Menu), Footer (Chân trang) chỉ một lần duy nhất. Các View con chỉ cần render phần nội dung thay đổi vào vị trí `@RenderBody()`.