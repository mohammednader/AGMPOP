var CycleDepartment = 0;
const DEPARTMENT_MARKUP = '<button onclick=searchUserType(#ID#) class="btn btn-link p-0">#NAME#</button>';

function getAllDepartments() {
    $.ajax({
        url: '/Common/GetAllDepartments',
        method: 'GET',
        success: response => {
            if (response && response.length) {
                $('#lstUserDepartments').empty();
                for (let d of response) {
                    let markup = DEPARTMENT_MARKUP
                        .replace(/#ID#/g, d.id)
                        .replace(/#NAME#/g, d.name);
                    $('#lstUserDepartments').append(markup);
                }
                $('#divUserDepartmentSearch').css('display', 'flex');
            } else {
                $('#divUserDepartmentSearch').hide();
            }
        },
    });
}
