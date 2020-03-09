function initUnlikeAttribute() {
    $.validator.addMethod('unlike',
        function (value, element, params) {
            var propertyValue = $(params[0]).val();
            var dependentPropertyValue = $(params[1]).val();
            return propertyValue !== dependentPropertyValue;
        });

    $.validator.unobtrusive.adapters.add('unlike',
        ['property'],
        function (options) {
            var element = $(options.form).find('#' + options.params['property'])[0];
            options.rules['unlike'] = [element, options.element];
            options.messages['unlike'] = options.message;
        });
}


//--prevent string char input
  
        function isNumberKey(evt) {
        var charCode = (evt.which) ? evt.which : evt.keyCode;
        if (charCode != 46 && charCode > 31
            && (charCode < 48 || charCode > 57))
        return false;

    return true;
}
 