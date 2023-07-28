$(document).ready(function(){
	// Activate tooltip
	$('[data-toggle="tooltip"]').tooltip();
	
	// Select/Deselect checkboxes
	var checkbox = $('table tbody input[type="checkbox"]');
	$("#selectAll").click(function(){
		if(this.checked){
			checkbox.each(function(){
				this.checked = true;                        
			});
		} else{
			checkbox.each(function(){
				this.checked = false;                        
			});
		} 
	});
	checkbox.click(function(){
		if(!this.checked){
			$("#selectAll").prop("checked", false);
		}
	});
});
$(document).ready(function () {
    var productIdToDelete;

    // Capture the click event on the delete button
    $(".delete").on("click", function () {
        productIdToDelete = $(this).data("id");
    });

    // When the delete confirmation modal is shown, update the form's action attribute with the appropriate delete URL
    $("#deleteProductModal").on("show.bs.modal", function () {
        var deleteUrl = "/home/deleteproduct/" + productIdToDelete;

        $.ajax({
            url: deleteUrl,
            type: "GET",
            success: function (data) {
              
            },
            error: function (xhr, status, error) {
                
            }
        });
    });


    // Reset the productIdToDelete variable when the delete confirmation modal is hidden
    $("#deleteProductModal").on("hidden.bs.modal", function () {
        productIdToDelete = null;
    });
});


$(document).ready(function () {
    var productIdToEdit;

    // Capture the click event on the edit button
    $(".edit").on("click", function () {
        productIdToEdit = $(this).data("id");
    });

    // When the edit confirmation modal is shown, update the form's action attribute with the appropriate delete URL
    $("#editProductModal").on("show.bs.modal", function () {
        var editUrl = "/home/editproduct/" + productIdToEdit;

        $.ajax({
            url: editUrl,
            type: "GET",
            success: function (data) {
              
            },
            error: function (xhr, status, error) {
                
            }
        });
    });


    // Reset the productIdToEdit variable when the edit confirmation modal is hidden
    $("#editProductModal").on("hidden.bs.modal", function () {
        productIdToEdit = null;
    });
});