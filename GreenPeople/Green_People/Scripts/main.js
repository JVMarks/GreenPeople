const menuItems = document.querySelectorAll('#menu .link');
function getScrollTopByHref(element) {
  const id = element.getAttribute('href');
  return document.querySelector(id).offsetTop;
}

function scrollToIdOnClick(event) {
  event.preventDefault();
  const to = getScrollTopByHref(event.currentTarget) - 80;/*80*/
  scrollToPosition(to);
}

menuItems.forEach(item => {
  item.addEventListener('click', scrollToIdOnClick);
});

function scrollToPosition(to) {
  window.scroll({
	top: to,
	behavior: "smooth",
  })
  smoothScrollTo(0, to);
}

function smoothScrollTo(endX, endY, duration) {
  const startX = window.scrollX || window.pageXOffset;
  const startY = window.scrollY || window.pageYOffset;
  const distanceX = endX - startX;
  const distanceY = endY - startY;
  const startTime = new Date().getTime();

  duration = typeof duration !== 'undefined' ? duration : 400;

  const easeInOutQuart = (time, from, distance, duration) => {
	if ((time /= duration / 2) < 1) return distance / 2 * time * time * time * time + from;
	return -distance / 2 * ((time -= 2) * time * time * time - 2) + from;
  };

  const timer = setInterval(() => {
	const time = new Date().getTime() - startTime;
	const newX = easeInOutQuart(time, startX, distanceX, duration);
	const newY = easeInOutQuart(time, startY, distanceY, duration);
	if (time >= duration) {
	  clearInterval(timer);
	}
	window.scroll(newX, newY);
  }, 1000 / 60);
};

//CARD-PRODUTOS
window.addEventListener('load', function () {
	setTimeout(lazyLoad, 1000);

});

function lazyLoad() {
	var card_images = document.querySelectorAll('.card-image');
	card_images.forEach(function (card_image) {
		var image_url = card_image.getAttribute('data-image-full');
		var content_image = card_image.querySelector('img');

		content_image.src = image_url;
		content_image.addEventListener('load', function () {
			card_image.style.backgroundImage = 'url(' + image_url + ')';
			card_image.className = card_image.className + ' is-loaded';
		});

	});

}