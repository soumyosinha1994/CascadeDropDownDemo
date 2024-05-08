
jQuery(document).ready(function () {
    $('#Country_Id').change(function () {
            var countryId = $(this).val();
        $.getJSON('/Home/GetStates', { Id: countryId }, function (states) {
                var statesSelect = $('#States');
            statesSelect.empty();
            statesSelect.append($('<option/>', {
                value: 0,
                text: 'Select State'
            }));
            $.each(states, function (index, state) {
                
                    statesSelect.append($('<option/>', {
                        value: state.value,
                        text: state.text
                    }));
                });
            });
        });
        $('#States').change(function () {
            var stateId = $(this).val();
            $.getJSON('/Home/GetCities', { Id: stateId }, function (cities) {
                var citiesSelect = $('#Cities');
                citiesSelect.empty();

                citiesSelect.append($('<option/>', {
                    value: 0,
                    text: 'Select City'
                }));
                $.each(cities, function (index, city) {
                    
                    citiesSelect.append($('<option/>', {
                        value: city.value,
                        text: city.text
                    }));
                });
            });
        });
    });
