@ModelType WODLife.Score
@Code
    ViewData("Title") = "LogWod"
End Code


<h2>LogWod</h2>

@Using (Html.BeginForm())
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Score</h4>
        <hr />
        @*  @Html.HiddenFor(Function(model) model.ApplicationUserID)
            @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
            <div class="form-group">
                @Html.LabelFor(Function(model) model.userID, htmlAttributes:=New With {.class = "control-label col-md-2"})
                <div class="col-md-10">
                    @Html.EditorFor(Function(model) model.userID, New With {.htmlAttributes = New With {.class = "form-control"}})
                    @Html.ValidationMessageFor(Function(model) model.userID, "", New With {.class = "text-danger"})
                </div>
            </div>  *@

        <div class="form-group">
            @Html.LabelFor(Function(model) model.wodID, "wodID", htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.DropDownListFor(Function(model) model.wodID, New SelectList(ViewBag.wodItems, "Value", "Text", New With {.id = "ddlWodNames", .class = "dropdown-item"}))
                @*    @Html.DropDownList("wodID", Nothing, htmlAttributes:=New With {.class = "form-control"})  *@
                @Html.ValidationMessageFor(Function(model) model.wodID, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.scalingNotes, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.scalingNotes, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.scalingNotes, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group">
            @Html.LabelFor(Function(model) model.scoreDate, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.scoreDate, New With {.htmlAttributes = New With {.class = "form-control datepicker"}})
                @Html.ValidationMessageFor(Function(model) model.scoreDate, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group" hidden="hidden" id="divAMRAP1">
            @Html.LabelFor(Function(model) model.scoreRounds, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.scoreRounds, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.scoreRounds, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group" hidden="hidden" id="divAMRAP2">
            @Html.LabelFor(Function(model) model.scoreReps, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.scoreReps, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.scoreReps, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group" hidden="hidden" id="divRFT">
            @Html.LabelFor(Function(model) model.scoreTime, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.scoreTime, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.scoreTime, "", New With {.class = "text-danger"})
            </div>
        </div>

        <div class="form-group" hidden="hidden" id="divLifting">
            @Html.LabelFor(Function(model) model.scoreWeight, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.scoreWeight, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.scoreWeight, "", New With {.class = "text-danger"})
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
    @Scripts.Render("~/bundles/bootstrap")
    <script type="text/javascript">
        $(function () { // will trigger when the document is ready
            $('.datepicker').datepicker(); //Initialise any date pickers
        });
    </script>
    <script type="text/javascript">
 $(function(){

      $("#wodID").change(function() {

          var t = $("#wodID").val();
          //var t = $(this).val();

            if (t !== "") {
                $.post("@Url.Action("GetDefault", "Wod")?val=" + t, function(res) {
                    if (res.Success === "true") {
                        var wodTypeID = res.data.TypeID;
                        //alert('value=' + t);
                      //enable the text boxes and set the value
                        if (wodTypeID == 1) {
                            // $("#divWidth").prop('style', 'display:unset;').val(res.Data.Width);
                            $("#divAMRAP1").prop('hidden', '');
                            $("#divAMRAP2").prop('hidden', '');
                            $("#divRFT").prop('hidden', 'hidden');
                            $("#divLifting").prop('hidden', 'hidden');
                        } else if (wodTypeID == 2) {
                            // $("#divHeight").prop('style', 'display:unset;').val(res.Data.Height);
                            $("#divAMRAP1").prop('hidden', 'hidden');
                            $("#divAMRAP2").prop('hidden', 'hidden');
                            $("#divRFT").prop('hidden', '');
                            $("#divLifting").prop('hidden', 'hidden');
                        } else if (wodTypeID == 3) {
                            $("#divAMRAP1").prop('hidden', 'hidden');
                            $("#divAMRAP2").prop('hidden', 'hidden');
                            $("#divRFT").prop('hidden', 'hidden');
                            $("#divLifting").prop('hidden', '');
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
