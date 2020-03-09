var Users = [];

var FilteredUsers = Users;

var SelectedUserIds = [];

var selectedUserDepartment = 0, selectedUserJobTitle = 0;

const USER_MARKUP = `<div class="list-group-item d-flex align-items-center">
                                <span class="ml-2">#NAME# <small class="text-secondary">#JOBTITLE#</small></span>
                                <span class="form-check ml-auto">
                                    <input type="checkbox" class="form-check-input chkUser" #CHECKED# id="chkUser-#ID#" onchange="toggleSelectUser(this)" />
                                    <label class="form-check-label" for="chkUser-#ID#"></label>
                                </span>
                            </div>`;

const NO_USER_MARKUP = '<div class="list-group-item d-flex justify-content-center">No users found</div>';

const JOBTITLE_MARKUP = '<button onclick=searchUserJobTitle(#ID#) class="btn btn-link p-0">#NAME#</button>';

const SELECTED_USER_MARKUP = `<div data-user="#ID#" class="list-group-item px-1 py-1 selected-user-item">
                                <div class="d-flex align-items-center">
                                    <!--<span style="content: url(/Content/Images/logo.png); width:20px; height:20px; border-radius:50%" class="mr-2"></span>-->
                                    <span class="font-small" style="max-width: 30ch; text-overflow:ellipsis">#NAME# <small class="text-secondary">#JOBTITLE#</small></span>
                                    <button onclick="removeUser(#ID#)" class="btn btn-link text-dark ml-auto mr-0 px-0"><i style="transform:scale(1.2)" class="fa fa-times-circle"></i></button>
                                </div>
                            </div>`;


function getAllUsers(skipSelected = false) {
    let url = '/Cycles/GetAllUsers?';
    if (!skipSelected && CycleId) {
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
            if (!skipSelected) {
                Users.filter(u => u.selected).forEach(e => {
                    if (SelectedUserIds.indexOf(e.id) == -1) {
                        SelectedUserIds.push(e.id);
                        addUser(e.id);
                    }
                });
            }
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
    if (users.length) {
        $('#userCount').text(`${users.length} items`);
        $('#userCount').show();
        for (let user of users) {
            let markup = USER_MARKUP
                .replace(/#ID#/g, user.id)
                .replace(/#NAME#/g, user.name)
                .replace(/#IMAGE#/g, user.image)
                .replace(/#JOBTITLE#/g, user.jobTitleName || "");
            if (SelectedUserIds.indexOf(user.id) != -1) {
                markup = markup.replace(/#CHECKED#/g, "checked");
            } else {
                markup = markup.replace(/#CHECKED#/g, "");
            }

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

function toggleSelectUser(element) {
    var id = element.id.split('-')[1];
    if (!isNaN(id)) {
        if (element.checked) {
            addUser(id);
        } else {
            removeUser(id);
        }
    }
}

function addUser(id) {
    user = Users.find(p => p.id == id);
    id = parseInt(id);
    if (user) {
        SelectedUserIds.push(id);
        user.quantity = 1;
        var markup = SELECTED_USER_MARKUP
            .replace(/#ID#/g, id)
            .replace(/#NAME#/g, user.name)
            .replace(/#JOBTITLE#/g, user.jobTitleName || "")
            .replace(/#MAX#/g, user.maxQuantity);

        $('#lstSelectedUsers').append(markup);

        $('#selectedUsersCount').text(SelectedUserIds.length);
    }
}

function removeUser(id) {
    SelectedUserIds = SelectedUserIds.filter(e => e != id);
    $('#selectedUsersCount').text(SelectedUserIds.length);

    $(`.selected-user-item[data-user=${id}]`).remove();
    $(`#chkUser-${id}`).prop('checked', false);
}

function getSelectedUsers(e) {
    return Users.filter(p => SelectedUserIds.indexOf(p.id) != -1);
}

function validateCycleUsers() {
    var users = getSelectedUsers();
    if (users && users.length) {
        if (users.some(u => u.jobTitleName && u.jobTitleName.toLowerCase() == 'bbx') && users.some(u => u.jobTitleName && u.jobTitleName.toLowerCase() == 'hr')) {
            return users.map(p => p.id);
        }
        else {
            Swal.fire({
                icon: 'warning',
                text: 'You must select at least one BBX and one HR',
            });
        }
    }
    else {
        Swal.fire({
            icon: 'warning',
            text: 'No users selected',
        });
        return null;
    }
}

function resetSelectedUsers() {
    SelectedUserIds = [];
}