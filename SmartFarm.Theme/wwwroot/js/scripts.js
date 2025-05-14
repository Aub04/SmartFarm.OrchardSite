document.addEventListener('DOMContentLoaded', function () {
    // Back to top button
    var backToTopButton = document.querySelector('.back-to-top');

    window.addEventListener('scroll', function () {
        if (window.pageYOffset > 300) {
            backToTopButton.style.display = 'flex';
            setTimeout(function () {
                backToTopButton.classList.add('show');
            }, 10);
        } else {
            backToTopButton.classList.remove('show');
            setTimeout(function () {
                if (!backToTopButton.classList.contains('show')) {
                    backToTopButton.style.display = 'none';
                }
            }, 500);
        }
    });

    backToTopButton.addEventListener('click', function (e) {
        e.preventDefault();
        window.scrollTo({
            top: 0,
            behavior: 'smooth'
        });
    });

    // Add active class to current nav item
    var currentLocation = window.location.pathname;
    var navLinks = document.querySelectorAll('.navbar-nav .nav-link');

    navLinks.forEach(function (link) {
        var linkPath = link.getAttribute('href');
        if (linkPath === currentLocation || (linkPath === '/' && currentLocation === '')) {
            link.classList.add('active');
        }
    });

    // Initialize any Bootstrap tooltips
    var tooltipTriggerList = [].slice.call(document.querySelectorAll('[data-bs-toggle="tooltip"]'));
    tooltipTriggerList.map(function (tooltipTriggerEl) {
        return new bootstrap.Tooltip(tooltipTriggerEl);
    });
});
// Fonction pour valider les formulaires
function validateForm(formId) {
    const form = document.getElementById(formId);
    if (!form) return;

    form.addEventListener('submit', function (e) {
        if (!form.checkValidity()) {
            e.preventDefault();
            e.stopPropagation();
        }

        form.classList.add('was-validated');
    });
}

// Initialiser la validation du formulaire de contact
document.addEventListener('DOMContentLoaded', function () {
    validateForm('contactForm');

    // Animation pour les éléments de la page
    const animatedElements = document.querySelectorAll('.fade-in, .slide-in');

    if (animatedElements.length > 0) {
        const observer = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add('visible');
                }
            });
        }, { threshold: 0.1 });

        animatedElements.forEach(element => {
            observer.observe(element);
        });
    }
});