ĐỒ ÁN MÔN AN TOÀN MẠNG MÁY TÍNH-NT101.O12.MMCL

Viết ứng dụng

Viết ứng dụng cho các giải thuật mã hòa và giải mã RSA và kiểm tra tính toán vẹn của file bằng MD5, SHA1,SHA256 

Thành viên nhóm gồm:

Nguyễn Tấn Phương Nam, MSSV: 20521633

Nguyễn Công Thành, MSSV: 20521917

Bùi Thanh Sơn, MSSV: 20521838

Mô tả:

Mã nguồn này kết hợp chức năng quản lý khóa RSA và kiểm tra tính toàn vẹn của file sau khi được giải mã. Nó cung cấp khả năng tạo, mã hóa và giải mã file hoặc thư mục sử dụng RSA, đồng thời cho phép so sánh giá trị băm (MD5, SHA1, SHA256) để xác minh tính toàn vẹn và độ tin cậy của dữ liệu.

Chức năng bao gồm:

Tạo khóa RSA với độ dài cụ thể và lưu khóa public/private vào tệp tin.
Hiển thị thông tin khóa dưới nhiều định dạng (XML, Hex, Byte array).
Mã hóa và giải mã file/thư mục sử dụng RSA.
Tính toán và so sánh giá trị băm của hai tệp để xác minh tính toàn vẹn.

Đánh giá hiệu suất:

Thời gian tạo khóa phụ thuộc vào độ dài khóa, càng lớn thì thời gian tạo khóa càng tăng.
Thời gian mã hóa/giải mã file/thư mục phụ thuộc vào kích thước và phức tạp của dữ liệu, cũng như thuật toán RSA.
Tính toán giá trị băm của file phụ thuộc vào kích thước của file, càng lớn thì thời gian tính toán càng tăng.
So sánh giá trị băm của hai tệp chỉ tốn thời gian rất ngắn, không tốn tài nguyên hệ thống nhiều.

Tổng kết:

Mã nguồn này cung cấp tính năng quản lý khóa RSA và kiểm tra tính toàn vẹn của dữ liệu sau khi được mã hóa. Tính hiệu suất được ảnh hưởng bởi kích thước và độ phức tạp của dữ liệu, cung cấp một cách tiếp cận linh hoạt và an toàn trong việc mã hóa, giải mã và kiểm tra tính toàn vẹn của thông tin.
