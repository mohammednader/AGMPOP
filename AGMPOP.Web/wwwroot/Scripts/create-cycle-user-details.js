var Users = [];

var FilteredUsers = Users;

var selectedUserDepartment = 0, selectedUserJobTitle = 0;

const USER_MARKUP = `<div class="list-group-item d-flex align-items-center">
                                <span class="ml-2">#NAME# <small class="text-secondary">#JOBTITLE#</small></span>
                                <span class="form-check ml-auto">
                                    <a class="btn btn-warning" for="tras-#ID#" href="/Report/transactionIndex?userName=#NAME#&cycleName=#CycleName#" target="_blank">transaction</a>
                                </span>
                            </div>`;

const NO_USER_MARKUP = '<div class="list-group-item d-flex justify-content-center">No users found</div>';

const JOBTITLE_MARKUP = '<button onclick=searchUserJobTitle(#ID#) class="btn btn-link p-0">#NAME#</button>';


function getAllUsers() {
    var CycleId = $("#cyceleId").val();
    
    let url = '/Cycles/GetAllUsersCycleDetails?';
    if (CycleId) {
        url += `cycleId=${CycleId}&`
    }
    if (CycleDepartment != 0) {
        url += `department=${CycleDepartment}`
    }
    $.ajax({
        url,
        method: 'GET',
        success: response => {
            Users = response.items || [];
            filterUsers();
        }
    });
}

function getAllUserJobTitles() {
    $.ajax({
        url: '/Common/GetAllJobTitles',
        method: 'GET',
        success: response => {
            if (response && response.length) {
                $('#lstUserJobTitles').empty();
                for (let d of response) {
                    let markup = JOBTITLE_MARKUP
                        .replace(/#ID#/g, d.id)
                        .replace(/#NAME#/g, d.name);
                    $('#lstUserJobTitles').append(markup);
                }
                $('#divUserJobTitleSearch').css('display', 'flex');
            } else {
                $('#divUserJobTitleSearch').hide();
            }
        },
    });
}


function filterUsers() {
    FilteredUsers = Users
        .filter(p => (selectedUserDepartment == 0 || p.departmentId == selectedUserDepartment)
                    && (selectedUserJobTitle == 0 || p.jobTitleId == selectedUserJobTitle));

    viewUsers(FilteredUsers);
}

function viewUsers(users) {
    $('#lstUsers').empty();
    var CycleName = $("#cycleName").val();
    if (users.length) {
        $('#userCount').text(`${users.length} items`);
        $('#userCount').show();
        for (let user of users) {
            let markup = USER_MARKUP
                .replace(/#ID#/g, user.id)
                .replace(/#NAME#/g, user.name)
                .replace(/#IMAGE#/g, user.image)
                .replace(/#CycleName#/g, CycleName)
                .replace(/#JOBTITLE#/g, user.jobTitleName || "");
            
            $('#lstUsers').append(markup);
        }
    } else {
        $('#lstUsers').append(NO_USER_MARKUP);
        $('#userCount').hide();
    }
}

function clearFilterUsers() {
    selectedUserDepartment = 0;
    selectedUserJobTitle = 0;
    getAllUsers(skipSelected = true);
}

function searchUserDepartment(departmentId) {
   
    selectedUserDepartment = departmentId;
    filterUsers();
}

function searchUserJobTitle(jobTitleId) {
    selectedUserJobTitle = jobTitleId;
    filterUsers();
}

function searchTextUsers(text) {
    var list = FilteredUsers.filter(p => !text || p.name.toLowerCase().indexOf(text.toLowerCase()) != -1);
    viewUsers(list);
}