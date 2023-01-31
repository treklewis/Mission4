//using jquery to attach a function to the Calculate Grade button on the home page
$('#buttonSend').click(function () {

    //declare grade variable and calculate final percentage using weights from syllabus
    var grade = 0

    grade = ((parseInt($('#assignments').val()) * 0.5) +
        (parseInt($('#groupProjects').val()) * 0.1) +
        (parseInt($('#quizzes').val()) * 0.1) +
        (parseInt($('#midterm').val()) * 0.1) +
        (parseInt($('#final').val()) * 0.1) +
        (parseInt($('#intex').val()) * 0.1))

    //calculate letter grade using grade variable and syllabus
    var letterGrade = ''

    if (grade >= 94) {
        letterGrade = 'A'
    } else if (grade >= 90) {
        letterGrade = 'A-'
    } else if (grade >= 87) {
        letterGrade = 'B+'
    } else if (grade >= 84) {
        letterGrade = 'B'
    } else if (grade >= 80) {
        letterGrade = 'B-'
    } else if (grade >= 77) {
        letterGrade = 'C+'
    } else if (grade >= 74) {
        letterGrade = 'C'
    } else if (grade >= 70) {
        letterGrade = 'C-'
    } else if (grade >= 67) {
        letterGrade = 'D+'
    } else if (grade >= 64) {
        letterGrade = 'D'
    } else if (grade >= 60) {
        letterGrade = 'D-'
    } else {
        letterGrade = 'E'
    }

    //print grade percentage and letter grade to text area on form
    $('#letterGrade').html('Final Percentage: ' + grade + '\n' + 'Letter Grade: ' + letterGrade)

})
