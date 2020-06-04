//Lấy các button mô tả nội dung
var acc = document.getElementsByClassName("btn");
var i;
//lặp qua các button để gán sự kiện
for (i = 0; i < acc.length; i++) {
    acc[i].onclick = function () {
        /* Thêm/xóa class active để đánh dấu các button đã được click */
        this.classList.toggle("active");

        /* Hiển thị hoặc ẩn nội dung khi button được click */
        var panel = this.nextElementSibling;
        if (panel.style.display === "block") {
            panel.style.display = "none";
        } else {
            panel.style.display = "block";
        }
    }
}