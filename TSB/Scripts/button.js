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



function easeOutExpo(x) {
    return x === 1 ? 1 : 1 - Math.pow(2, -10 * x);
}

function animateNumber(finalNumber, duration = 5000, startNumber = 0, callback) {
    const startTime = performance.now()
    function updateNumber(currentTime) {
        const elapsedTime = currentTime - startTime
        if (elapsedTime > duration) {
            callback(finalNumber)
        } else {
            const timeRate = (1.0 * elapsedTime) / duration
            const numberRate = easeOutExpo(timeRate)
            const currentNumber = Math.round(numberRate * finalNumber)
            callback(currentNumber)
            requestAnimationFrame(updateNumber)
        }
    }
    requestAnimationFrame(updateNumber)
}

document.addEventListener('DOMContentLoaded', function () {
    animateNumber(25, 3000, 0, function (number) {
        const formattedNumber = number.toLocaleString()
        document.getElementById('transaction-count').innerText = formattedNumber
    })

    animateNumber(8, 3000, 0, function (number) {
        const formattedNumber = number.toLocaleString()
        document.getElementById('city-count').innerText = formattedNumber
    })

    animateNumber(500, 3000, 0, function (number) {
        const formattedNumber = number.toLocaleString()
        document.getElementById('customer-count').innerText = formattedNumber
    })
})