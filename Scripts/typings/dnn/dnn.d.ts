interface dnn{    
    getVar(keyName:string, defaultValue:any) : any    
}

declare module "dnn"{
    export = dnn;
}

declare var dnn:dnn;