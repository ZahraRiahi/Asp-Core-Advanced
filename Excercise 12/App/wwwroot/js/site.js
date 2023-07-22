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
    document.addEventListener("DOMContentLoaded", function () {
        const modal = document.getElementById("deleteProductModal");
        const closeBtn = modal.querySelector(".close");
        const confirmBtn = modal.getElementById("confirmDeleteBtn");
        const cancelBtn = modal.getElementById("cancelDeleteBtn");
        const deleteLinks = document.querySelectorAll(".delete");

        function showModal() {
            modal.style.display = "block";
        }

        function hideModal() {
            modal.style.display = "none";
        }

        deleteLinks.forEach(link => {
            link.addEventListener("click", function (event) {
                event.preventDefault();
                const itemId = this.getAttribute("data-id");
                showModal();

                confirmBtn.addEventListener("click", function () {
                   
                    hideModal();
                });

                cancelBtn.addEventListener("click", function () {
                    hideModal();
                });
            });
        });

        closeBtn.addEventListener("click", function () {
            hideModal();
        });

        window.addEventListener("click", function (event) {
            if (event.target === modal) {
                hideModal();
            }
        });
    });
