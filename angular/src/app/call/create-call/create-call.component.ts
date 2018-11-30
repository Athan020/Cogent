import { Component, ViewChild, Injector, Output, EventEmitter, ElementRef } from '@angular/core';
import { ModalDirective } from 'ngx-bootstrap';
import { CallServiceProxy, CallDto, UserDto,  SessionServiceProxy } from '@shared/service-proxies/service-proxies';
import { AppComponentBase } from '@shared/app-component-base';
import { finalize } from 'rxjs/operators';

@Component({
  selector: "create-call-modal",
  templateUrl: "./create-call.component.html"
})
export class CreateCallComponent extends AppComponentBase {
  @ViewChild("createCallModal") modal: ModalDirective;
  @ViewChild("modalContent") modalContent: ElementRef;

  @Output() modalSave: EventEmitter<any> = new EventEmitter<any>();

  active: boolean = false;
  saving: boolean = false;
  call: CallDto = null;
  users : UserDto[]=[];
  

  constructor(injector: Injector, private _callService: CallServiceProxy,private _sessionService:SessionServiceProxy) {
    super(injector);
  }

  ngOnInit(): void {
      //Called after the constructor, initializing input properties, and the first call to ngOnChanges.
      //Add 'implements OnInit' to the class.
      
      
  }

  show(): void {
    this.active = true;
    this.modal.show();
    this.call = new CallDto();
    // this._sessionService.getCurrentLoginInformations().subscribe((output) => this.call.userId  = output.user.id)
  }

  onShown(): void {
    $.AdminBSB.input.activate($(this.modalContent.nativeElement));
  }

  save(): void {
    this.saving = true;
    this._callService
      .create(this.call)
      .pipe(
        finalize(() => {
          this.saving = false;
        })
      )
      .subscribe(() => {
        this.notify.info(this.l("SavedSuccessfully"));
        this.close();
        this.modalSave.emit(null);
      });
  }

  close(): void {
    this.active = false;
    this.modal.hide();
  }
}