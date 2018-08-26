@ModelType WODLife.TestViewModel
@Code
    ViewData("Title") = "TestCreate"
End Code

<h2>TestCreate</h2>

@Using (Html.BeginForm()) 
    @Html.AntiForgeryToken()
    
    @<div class="form-horizontal">
        <h4>TestViewModel</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With { .class = "text-danger" })
        
    <div id="editablePane">
         <div id="divWidth" class="form-group" hidden="hidden">
            @Html.LabelFor(Function(model) model.Width, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Width, New With {.htmlAttributes = New With {.class = "myEditable"}})
                @Html.ValidationMessageFor(Function(model) model.Width, "", New With { .class = "text-danger" })
            </div>
        </div>

        <div id="divHeight" class="form-group" hidden="hidden">
            @Html.LabelFor(Function(model) model.Height, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.Height, New With {.htmlAttributes = New With {.class = "myEditable"}})
                @Html.ValidationMessageFor(Function(model) model.Height, "", New With { .class = "text-danger" })
            </div>
        </div>
    </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.SelectedWidget, htmlAttributes:= New With { .class = "control-label col-md-2" })
            <div class="col-md-10">
                @Html.DropDownListFor(Function(model) model.SelectedWidget, Model.Widgets, "selected", New With {.class = "dropdown-item"})
             @*   @Html.EditorFor(Function(model) model.SelectedWidget, New With {.htmlAttributes = New With {.class = "form-control"}}) *@
                @Html.ValidationMessageFor(Function(model) model.SelectedWidget, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts 
    @Scripts.Render("~/bundles/jqueryval")
<script type="text/javascript">
 $(function(){

      $("#SelectedWidget").change(function() {

          var t = $("#SelectedWidget").val();
          //var t = $(this).val();

            if (t !== "") {
                $.post("@Url.Action("GetDefault", "Test")?val=" + t, function(res) {
                    if (res.Success === "true") {
                        //alert('value=' + t);
                      //enable the text boxes and set the value
                        if (t == 1) {            
                           // $("#divWidth").prop('style', 'display:unset;').val(res.Data.Width);
                            $("#divWidth").prop('hidden', '');
                            $("#divHeight").prop('hidden', 'hidden');
                        } else if (t == 2) {
                           // $("#divHeight").prop('style', 'display:unset;').val(res.Data.Height);
                            $("#divWidth").prop('hidden', 'hidden');
                            $("#divHeight").prop('hidden', '');
                        }
                    } else {
                        alert("Error getting data!");
                    }
                });
            } else {
                //Let's clear the values and disable :)
                $("input.editableItems").val('').prop('disabled', true);
            }

        });
 });

</script>
End Section
