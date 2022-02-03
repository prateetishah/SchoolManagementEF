﻿@ModelType SchoolManagementEF.Student
@Code
    ViewData("Title") = "Details"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<h2>Details</h2>

<div>
    <h4>Student</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.LastName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.LastName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FirstName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FirstName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.MiddleName)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MiddleName)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.EnrollmentDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.EnrollmentDate)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.StudentID }) |
    @Html.ActionLink("Back to List", "Index")
</p>
