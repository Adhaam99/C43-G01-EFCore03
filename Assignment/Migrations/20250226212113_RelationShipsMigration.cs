using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Assignment.Migrations
{
    /// <inheritdoc />
    public partial class RelationShipsMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DepartmentID",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "StudentID",
                table: "stud_Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ManagedDepartmentID",
                table: "Instructors",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TopicID",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Course_Insts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Students_DepartmentID",
                table: "Students",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_CourseID",
                table: "stud_Courses",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_stud_Courses_StudentID",
                table: "stud_Courses",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ManagedDepartmentID",
                table: "Instructors",
                column: "ManagedDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicID",
                table: "Courses",
                column: "TopicID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_CourseID",
                table: "Course_Insts",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Course_Insts_InstructorID",
                table: "Course_Insts",
                column: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Courses_CourseID",
                table: "Course_Insts",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorID",
                table: "Course_Insts",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses",
                column: "TopicID",
                principalTable: "Topics",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments",
                column: "Ins_ID",
                principalTable: "Instructors",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_ManagedDepartmentID",
                table: "Instructors",
                column: "ManagedDepartmentID",
                principalTable: "Departments",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Courses_Courses_CourseID",
                table: "stud_Courses",
                column: "CourseID",
                principalTable: "Courses",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_stud_Courses_Students_StudentID",
                table: "stud_Courses",
                column: "StudentID",
                principalTable: "Students",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Courses_CourseID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Course_Insts_Instructors_InstructorID",
                table: "Course_Insts");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Topics_TopicID",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_Ins_ID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_ManagedDepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_Courses_CourseID",
                table: "stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_stud_Courses_Students_StudentID",
                table: "stud_Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Departments_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_DepartmentID",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_stud_Courses_CourseID",
                table: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_stud_Courses_StudentID",
                table: "stud_Courses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ManagedDepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_Ins_ID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Courses_TopicID",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_CourseID",
                table: "Course_Insts");

            migrationBuilder.DropIndex(
                name: "IX_Course_Insts_InstructorID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "DepartmentID",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "stud_Courses");

            migrationBuilder.DropColumn(
                name: "StudentID",
                table: "stud_Courses");

            migrationBuilder.DropColumn(
                name: "ManagedDepartmentID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "TopicID",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "CourseID",
                table: "Course_Insts");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Course_Insts");
        }
    }
}
