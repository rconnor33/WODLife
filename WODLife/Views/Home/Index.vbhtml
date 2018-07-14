@Code
    ViewData("Title") = "Home Page"
End Code

<div class="row">
    <div class="col-md-6 margin-top-20"><a href="#" class="btn btn-primary btn-lg btn-block"><span class="glyphicon glyphicon-cog"></span>Add WOD</a></div>
    <div class="col-md-6 margin-top-20"><a href="@Url.Action("Details", "Wod")" class="btn btn-primary btn-lg btn-block">View WOD</a></div>
</div>

@section scripts
<script>var testing = true;</script>
End Section

@*
    <div class="alert">
        <h4>You are using @Request.Browser.Browser, which should be fine.</h4>
    </div>


        <div class="alert-danger">
            <p>
                @code dim amounts As New List(Of Decimal)
                    amounts.Add(25D)
                    amounts.Add(24.5D)
                    amounts.Add(-40D)
                    amounts.Add(75.99D)
                    amounts.Add(146.25D)
                End Code

                <ul>
                    @code For Each amount In amounts end code

                        <li>@(formatamount(amount))</li>
                            @code Next end code


                </ul>

               @helper formatamount(amount As Decimal)
                   Dim colour = "green"
                   If amount < 0 Then
                       colour = "red"
                   End If

                @<span style="color:@colour">@String.Format("{0:c}", amount)</span>
                   End helper
            </p>
        </div>
*@