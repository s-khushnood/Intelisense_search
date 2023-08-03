$(document).ready(() => {
    var students;
    const POSTS_API = "http://localhost:54752/getallstudents";
    fetchstudents();
    function displaystudents() {
        $(".posts-container").empty();
    
        for (let i = 0; i < students.length; i++) {
          $(".posts-container").append(makePost(students[i]));
        }
      }
      function makePost(student) {
        return `
    
                    <div class="post">
                        <h2>Student ID: ${student.ID}</h2>
                        <p> Student FirstName: ${student.FirstName}</p>
                        <p> Student LastName: ${student.LastName}</p>
                        <p> Student Age:${student.Age}</p>
                        <p>Student Course: ${student.Course}</p>
                    </div>
    
                    `;
      }

      function displayError(error) {
        $(".posts-container").html(
          '<div class="error">Some Error has occured!</div>'
        );
      }
    
      function fetchstudents() {
        $.ajax({
          method: "GET",
    
          url: POSTS_API,
    
          success: (data) => {
            students = data;
    
            displaystudents();
          },
    
          error: displayError,
        });
    
}

$("#searchinput").keyup(function(){
    $.ajax({
        method: "GET",
        url: "http://localhost:54752/FetchbyName?str="+$("#searchinput").val(),
        success: (data) => {
          students = data;
          $(".mylist").empty();
          for (let i = 0; i < students.length; i++) {
            $(".mylist").append(
    
                `<li>${students[i].FirstName}  ${students[i].LastName}</li>`
            );
          }
        },
        error: ()=>{
            alert('error occured while fetching students');
        },
      });
})

})



