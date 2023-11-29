
    document.addEventListener('DOMContentLoaded', function () {
        var checkboxes = document.querySelectorAll('.date-checkbox');

        checkboxes.forEach(function (checkbox) {
            checkbox.addEventListener('change', function () {
                var dateInput = this.parentElement.nextElementSibling.querySelector('.date-input');

                if (this.checked) {
                    var today = new Date().toISOString().split('T')[0];
                    dateInput.value = today;
                } else {
                    dateInput.value = '';
                }
            });
        });

    });


