				HƯỚNG DẪN SỬ DỤNG

Bước 1: Khởi động phần mềm SQL Server trên máy và chạy file "QueryIT008LT.sql"

Bước 2: Chọn file App.config theo đường dẫn BaiLT_SQL_21520455_PhanTuanThanh\BaiLT_SQL_21520455_PhanTuanThanh\App.config

Bước 3: Bấm chuột phải vào file App.config và chọn "Open with -> Notepad"

Bước 4: Tại đây ta thấy mặc định sẽ hiển thị
	<connectionStrings>
		<add name="IT008-LT" connectionString="Data Source = SV-TRƯỜNG-TIU; Initial Catalog = IT008LT; Integrated Security = True;" />
	</connectionStrings>

`	=> Sửa "SV-TRƯỜNG-TIU" sau chữ "Data Source = " thành tên Server của máy bạn là được.
	______________________________________________________________________________
       	|   Nếu bạn chưa biết cách để lấy Server name thì đọc hướng dẫn dưới đây:     |
	|	Bước 1: Khởi động phần mềm SQL Server trên máy			      |
	|									      |
	|	Bước 2: Phần mềm sẽ hiển thị ô cửa sổ nhỏ có tên Server name cần tìm. |
	|	// Lưu ý: Phải chọn Authenciation: Windows Authenciation	      |
	|_____________________________________________________________________________|

## Sau khi cài đặt đã xong, bây giờ các bạn chỉ cần mở Visual Studio lên, build lại chương trình và chạy thôi.