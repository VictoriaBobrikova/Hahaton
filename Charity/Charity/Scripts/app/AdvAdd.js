function addItem() {
    $('.item_container').append($('<div class="col-md-12 adv2 item"><div class="row"><div class="col-md-4"><img src="~/Content/Images/blagotvor.jpg" class="img-circle" style="width:150px;"><br><br><p><input type="file" name="pic" class="form-control" style="width: 145px;"></p></div><div class="col-md-8"><form role="form"><div class="form-group"><label>Название: </label><input type="text" name="name" class="form-control" /><br><label>Информация: </label><textarea rows="3" cols="45" name="descrtiption" class="form-control"></textarea></div></form></div></div></div>'));
};

function takeAdvById(id) {
    window.location.href = "/Home/TakeById?id=" + id;
};

function saveAdv() {
    var name = document.getElementById("adv_name").value;
    var description = document.getElementById("adv_description").value;

    var items = document.getElementsByClassName('item');
    for (var i = 0; i < items.length; i++) {
        var name = items[i].getElementsByClassName('item-name').value;
        var description = items[i].getElementsByClassName('item-description').value;
    } 
};