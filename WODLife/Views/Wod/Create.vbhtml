@ModelType WODLife.Wod
@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm("Create", "Wod", FormMethod.Post, New With {.class = "form-horizontal", .role = "form"})
    @Html.AntiForgeryToken()

    @<div class="form-horizontal">
        <h4>Wod</h4>
        <hr />
        @Html.ValidationSummary(True, "", New With {.class = "text-danger"})
        <div class="form-group">
            @Html.LabelFor(Function(model) model.wodName, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.wodName, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.wodName, "", New With {.class = "text-danger"})
            </div>
        </div>
     @*   <div class="form-group">
            @Html.LabelFor(Function(model) model.wodType, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10">
                @Html.EditorFor(Function(model) model.wodType, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.wodType, "", New With {.class = "text-danger"})
            </div>
        </div> *@
        <div class="form-group dropdown-header">
            @Html.LabelFor(Function(model) model.wodType, htmlAttributes:=New With {.class = "control-label col-md-2"})
        <div class="col-md-10">
           @Html.DropDownListFor(Function(model) model.wodTypeID, New SelectList(ViewBag.wodTypeItems, "Value", "Text", New With {.id = "ddlWodTypes", .class = "dropdown-item"})) 
        @*    @Html.DropDownList("WodTypeItems", "Please select a WOD Type...") *@
            @Html.ValidationMessageFor(Function(model) model.wodTypeID, "", New With {.class = "text-danger"})
        </div>
        </div>
        <div Class="form-group">
            @Html.LabelFor(Function(model) model.wodDescription, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10 bootstrap form-text">
                @Html.TextAreaFor(Function(model) model.wodDescription, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.wodDescription, "", New With {.class = "text-danger"})
            </div>
        </div>
        <div class="form-group">
            @Html.LabelFor(Function(model) model.wodNotes, htmlAttributes:=New With {.class = "control-label col-md-2"})
            <div class="col-md-10 bootstrap form-text">
                @Html.TextAreaFor(Function(model) model.wodNotes, New With {.htmlAttributes = New With {.class = "form-control"}})
                @Html.ValidationMessageFor(Function(model) model.wodNotes, "", New With {.class = "text-danger"})
            </div>
        </div>


        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <input type="submit" value="Create WOD" class="btn btn-default" />
            </div>
        </div>
    </div>
End Using

                                <div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
