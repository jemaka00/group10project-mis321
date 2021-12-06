class Login {
    constructor(form, fields) {
        this.form = form;
        this.fields = fields;
        this.validateonSubmit();
    }

    validateonSubmit(){
        let self = this;

        this.form.addEventListener("submit", (e) => {
            e.preventDefault();
            var error = 0;
            self.fields.forEach((field) => {
                const input = document.querySelector(field);
                if (self.validateFields(input) == false) {
                    error++;
                }
                if (error == 0){
                    this.form.submit();
                }
            });
        });
    }

    validateFields(field) {
        if(field.value.trim() == "") {
            this.setStatus(
                field,
                "cannot be blank, error"
            );
            return false;
        }
        else {
            if (field.type == "empPassword"){
                if (field.value.length < 6) {
                    this.setStatus(
                        field,
                        "cannot be blank, error"
                    );
                    return false;
                } else {
                    this.setStatus(field, null, "success")
                    return true;
                }
            } else {
                this.setStatus(field, null, "success");
                return true;
            }
        }
    }
}

const form = document.querySelector(".form1");
if (form) {
    const fields = ["empEmail", "empPassword"];
    const validator = new Login(form, fields);
}

