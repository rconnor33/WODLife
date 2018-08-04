@ModelType WODLife.WodType
@Code
    ViewData("Title") = "View"
End Code

<h2>View</h2>

<div>
    <h4>WodType</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.wodType)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.wodType)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.wodTypeID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
