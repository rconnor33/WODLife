@Modeltype IEnumerable(Of WODLife.Wod)
@*@ModelType WODLife.Wod*@
@Code
    ViewData("Title") = "Details"
End Code

@*<!--<div class="row">
        <div class="col-md-6 offset-3">
            <h4>Wod Details</h4>
            <hr />
            <dl class="dl-horizontal">
                <dt>

                </dt>

                <dd>
                    @Html.DisplayFor(Function(model) model.wodName)
                </dd>

            </dl>
        </div>
    </div>--> *@
@*
<script>
    //possible jscript to modify and use for dynamic display of score type.
    $("#Sub").hide();
$("#subject").change(function(){
    if ($(this).val() === "Other"){
        $("#Sub").show();
        $("#subject").hide();
    }else{
        $("#Sub").hide();
    }
    });
    </script>
    *@
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.wodName)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.wodDescription)
        </th>
        <th>
            @*  @Html.DisplayNameFor(Function(model) model.wodType)*@
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.wodNotes)
        </th>
        <th></th>
    </tr>
    @code For Each item In Model end code
    <tr>
        <td>
            @Html.DisplayFor(Function(model) item.wodName)
        </td>
        <td>
            @Html.DisplayFor(Function(model) item.wodDescription)
        </td>
        <td>
            @*  @Html.DisplayFor(Function(model) item.wodType) *@
        </td>
        <td>
            @Html.DisplayFor(Function(model) item.wodNotes)
        </td>
    </tr>
    @code Next end code
</table>
