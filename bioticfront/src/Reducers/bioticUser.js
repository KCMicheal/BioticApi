import { ACTION_TYPES } from '../Actions/BioticUser';

const initialState = {
    list: []
}

export const bioticUser = ( state = initialState, action) => {
    switch(action.type) {
        case ACTION_TYPES.FETCH_ALL:
            return {
                ...state,
                list: [...action.payload]
            }
            break;
        default:
            return state;
    }
}