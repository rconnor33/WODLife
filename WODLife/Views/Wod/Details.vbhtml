@Modeltype WodViewModel
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
        <th></th>
        <th>
            @Html.DisplayNameFor(Function(model) model.WodList.Item(1).wodName)
        </th>
         <th>
                @Html.DisplayNameFor(Function(model) model.WodList.Item(1).wodDescription)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.WodList.Item(1).wodType)
            </th>
            <th>
                @Html.DisplayNameFor(Function(model) model.WodList.Item(1).wodNotes)
            </th>
        <th></th>
    </tr>

    @code For Each item In Model.WodList end code
    <tr>
        <td>
                @Html.ActionLink("Edit", "Edit", New With {.id = item.wodID})
               @* @Html.ActionLink("Back to List", "Index") *@
        </td>
        <td>
            @Html.DisplayFor(Function(model) item.wodName)
        </td>
        <td>
            @Html.DisplayFor(Function(model) item.wodDescription)
        </td>
        <td>
            @Html.DisplayFor(Function(model) item.wodType.wodType)
        </td>
        <td>
            @Html.DisplayFor(Function(model) item.wodNotes)
        </td>
    </tr>
    @code Next end code
</table>
