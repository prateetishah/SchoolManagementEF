@ModelType SchoolManagementEF.Course
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Course</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.Title)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Title)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Credits)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Credits)
        </dd>

    </dl>

    <table class="table table-condensed table-responsive">
        <tr>
            <th>Course Title</th>
            <th>Credits</th>
            <th>Grades</th>
        </tr>
        @For Each item In Model.Enrollments
            @<tr>
                <td>
                    <p>
                        @item.Course.Title
                    </p>
                </td>
                <td>
                    <p>
                        @item.Course.Credits
                    </p>
                </td>
                <td>
                    <p>
                        @item.Grade
                    </p>
                </td>
            </tr>
        Next
    </table>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With {.id = Model.CourseID}) |
    @Html.ActionLink("Back to List", "Index")
</p>
