@ModelType WODLife.Wod
@Code
    ViewData("Title") = "Details"
End Code

<div class="row">
    <div class="col-md-6 offset-3">
    <h4>Wod Details</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.wodName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.wodName)
        </dd>

    </dl>
        </div>
</div>
