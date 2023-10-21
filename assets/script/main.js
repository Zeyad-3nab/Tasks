
let todoContainer = [];
let id=0;
const todoInput = document.querySelector("#todo");
const addBtn = document.querySelector(".addBtn");
const largeData=document.querySelector(".InputIsLarge")
const deleteBtn=document.querySelector(".deleteBtn");
const deleteInput=document.querySelector("#todoDelete_Edit")
const deleteNotFound=document.querySelector(".idNotFounded")
const searchDiv=document.querySelector(".SearchTr")
const searchvalue=document.querySelector(".searchValue");
const searchiD=document.querySelector(".searchId");
const searchBtn=document.querySelector(".searchBtn")
const searchInput=document.querySelector("#todoSearch")
const SearchIdNotFounded=document.querySelector(".SearchIdNotFounded")
const updateInput=document.querySelector("#todoEdit")
const updateBtn=document.querySelector(".editNowBtn")
const editBtn=document.querySelector(".editBtn")
function update(){
  let flag=false;
  let index;
  for (let i = 0; i < todoContainer.length; i++) {
    if(deleteInput.value==todoContainer[i].taskId){
      updateInput.style.display="flex";
      deleteInput.style.display="none"
      deleteBtn.style.display="none"
      editBtn.style.display="none"
      updateBtn.style.display="flex"
      index=i;
      flag=true;
      break;
    }
  }  
    if(flag==false){
      deleteNotFound.style.display="flex";
          setTimeout(()=>{
            deleteNotFound.style.display="none";
          },1000)
    }
    updateBtn.addEventListener("click",()=>{
      ubdateNow(index)
      
    })
}

function ubdateNow(i) {
  todoContainer[i].taskName=updateInput.value;
  updateInput.style.display="none";
  deleteInput.style.display="flex"
  deleteBtn.style.display="flex"
  editBtn.style.display="flex"
  updateBtn.style.display="none"
  displayTodo();
}
editBtn.addEventListener("click",update)


//Search Fun
function search(){
  let flag=false;
  if(todoContainer.length==0){
    SearchIdNotFounded.style.display="flex";
    setTimeout(()=>{
      SearchIdNotFounded.style.display="none";
    },1000)
  }
  else{
    for(var i=0;i<todoContainer.length;i++){
      if(todoContainer[i].taskId==searchInput.value){
        console.log("Hello");
        searchvalue.textContent=todoContainer[i].taskName
        searchiD.textContent=todoContainer[i].taskId;
        flag=true;
        break;
      }
      }
      if(flag==true){
        searchDiv.style.display="flex";
        setTimeout(()=>{
          searchDiv.style.display="none";
        },5000)
      }
      else{
        searchDiv.style.display="none";
        SearchIdNotFounded.style.display="flex";
            setTimeout(()=>{
              SearchIdNotFounded.style.display="none";
            },1000)
      }
  }
  }
  searchBtn.addEventListener("click", search)


//Delete Fun
function deleteTodo(){
  //flag to check the id is in array or not
  let flag=false;
  //condition to check if array is empty or not
  if(todoContainer.length==0){
    deleteNotFound.style.display="flex";
    setTimeout(()=>{
      deleteNotFound.style.display="none";
    },1000)
  }
  else{
    //for to loop on array to find id
    for(var i=0;i<todoContainer.length;i++){
      //condition to check the id is in array or not
      if(todoContainer[i].taskId==deleteInput.value){
        //splice method is delete part of array(start element,Number of element)
        todoContainer.splice(i,1)
        //display array after splice
        displayTodo();
        flag=true;
        break;
      }
    }
    //condition that tell me id is in array or not
    if(flag==false){
      deleteNotFound.style.display="flex";
          setTimeout(()=>{
            deleteNotFound.style.display="none";
          },1000)
    }
    else{
      deleteNotFound.style.display="none";
    }
  }
}
deleteBtn.addEventListener("click",deleteTodo)


function validation() {
  let range=/^\w{2,20}$/
  if(range.test(todoInput.value)){
    return true;
  }
  else{
    return false;
  }
}
//Add Task Fun
function addTodoTasks() {
  if(validation()){
 //unique id
 id++
 //Object of task
 let todoData = {
   taskName: todoInput.value,
   taskId:id
 };
 //Put The Object in Array
 todoContainer.push(todoData);
 localStorage.setItem("todoTasks", JSON.stringify(todoContainer));
 //Display This todo
 displayTodo(todoContainer.indexOf(todoData));
  }
  else{
    largeData.style.display="flex"
    setTimeout(() => {
      largeData.style.display="none"
    }, 1000);
  }
 
}
addBtn.addEventListener("click", addTodoTasks);


//Display Fun
function displayTodo() {
  let temp = "";
  todoContainer.forEach(
    (todo) =>
    //Template that go to html
      (temp += `<tr id="${todo.taskId}">
      <td>${todo.taskName}</td>
      <td>${todo.taskId}</td>
  </tr>`)
  );
  document.getElementById("showTodo").innerHTML = temp;
}

