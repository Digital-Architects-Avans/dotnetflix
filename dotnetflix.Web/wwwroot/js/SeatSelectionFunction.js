const seats = document.querySelectorAll('.row .seat:not(.occupied)');
const count = document.getElementById('count');
const total = document.getElementById('total');

function updateSelectedCount() {
    const selectedSeats = document.querySelectorAll('.row .seat.selected');
    const selectedSeatsCount = selectedSeats.length;
    count.innerText = selectedSeatsCount;
    total.innerText = selectedSeatsCount * ticketPrice;
}

function toggleSeatSelection(seat) {
    seat.classList.toggle('selected');
    updateSelectedCount();
}

seats.forEach(seat => {
    seat.addEventListener('click', () => toggleSeatSelection(seat));
});