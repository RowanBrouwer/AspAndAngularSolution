import { Component, Inject } from '@angular/core';
import { HttpClient, HttpParams } from '@angular/common/http';

@Component({
  selector: 'app-quiz',
  templateUrl: './quiz.component.html',
  styleUrls: ['./quiz.component.css']
})
/** Quiz component*/
export class QuizComponent {
  public question: Question;
  public max: number = 0;
  private questionNr:number = 1;
  private baseUrl: string;
  public correct: boolean = null;
  public deactivate: boolean = false;
  public lastQuestion: boolean = false;

  constructor(protected http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.baseUrl = baseUrl;
    }

  GetMaximumQuestions() {
    return this.http.get<number>(this.baseUrl + 'api/Question/GetMaxQuestions').subscribe(result => {
      this.max = result;
    }, error => console.error(error));
  }

  GetFirstQuestion(): void {
    this.http.get<Question>(`${this.baseUrl}api/Question/GetNextQuestion/Id`, { params: new HttpParams().set('Id', this.questionNr.toString()) }).subscribe(data => {
      this.question = data;
    }, error => console.error(error));
  }

  GetNextQuestion(): void { 
    this.correct = null;
    this.http.get<Question>(`${this.baseUrl}api/Question/GetNextQuestion/Id`, { params: new HttpParams().set('Id', this.questionNr.toString()) }).subscribe(data => {
      this.question = data;
    }, error => console.error(error));
      this.deactivate = false;
  }

  CheckAwnser(awnser: Awnser) {
    if (awnser.id === this.question.correctAnswer.id) {
      this.correct = true;
      this.deactivate = true;
      this.questionNr++;
      this.CheckIfLastQuestion();
    }
    else {
      this.correct = false;
      this.deactivate = true;
      this.questionNr++;
      this.CheckIfLastQuestion();
    }
  }

  CheckIfLastQuestion() {
    if (!(this.questionNr <= this.max)) {
      this.lastQuestion = true;
      window.alert("You completed the quiz!");
    }
  }

  ngOnInit() {
    this.GetMaximumQuestions();
    this.GetFirstQuestion();
  }
}


export interface Awnser {
  id: Number;
  actualAwnser: String;
};

export enum ChapterEnum {
  Azure_Core_Concepts,
  Azure_Core_Services,
  Azure_Core_Solutions_and_Management_tools,
  General_Security_and_Network_security,
  Identity_Governance_Privacy_and_Compliance_Features,
  Azure_Cost_Management_and_service_Level_Agreements
};

export interface Question {
  id: Number;
  actualQuestion: String;
  awnsers: Awnser[];
  correctAnswer: Awnser;
  chapter: ChapterEnum;
};
